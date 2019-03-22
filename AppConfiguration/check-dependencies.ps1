param([switch]$Isolated, [switch]$Accounts, [switch]$PlatyPS, [switch]$Pester)
$ErrorActionPreference = 'Stop'

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NoExit -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

function DownloadModule ([bool]$predicate, [string]$path, [string]$moduleName, [string]$versionMinimum) {
  if($predicate) {
    $module = Get-Module -ListAvailable -Name $moduleName
    if((-not $module) -or ($versionMinimum -and ($module | ForEach-Object { $_.Version } | Where-Object { $_ -ge [System.Version]$versionMinimum } | Measure-Object).Count -eq 0)) {
      $null = New-Item -ItemType Directory -Force -Path $path
      Write-Host -ForegroundColor Green "Installing local $moduleName module into '$path'..."
      if($versionMinimum) {
        Find-Module -Name $moduleName -MinimumVersion $versionMinimum -Repository PSGallery | Save-Module -Path $path
      } else {
        Find-Module -Name $moduleName -Repository PSGallery | Save-Module -Path $path
      }
    }
  }
}

$all = (@($Accounts.IsPresent, $PlatyPS.IsPresent, $Pester.IsPresent) | Select-Object -Unique | Measure-Object).Count -eq 1

$localModulesPath = Join-Path $PSScriptRoot 'generated\modules'
if(Test-Path -Path $localModulesPath) {
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

DownloadModule -predicate ($all -or $Accounts) -path $localModulesPath -moduleName 'Az.Accounts' -versionMinimum '1.4.0'
DownloadModule -predicate ($all -or $PlatyPS) -path $localModulesPath -moduleName 'platyPS' -versionMinimum '0.13.0'
DownloadModule -predicate ($all -or $Pester) -path $localModulesPath -moduleName 'Pester' -versionMinimum ''