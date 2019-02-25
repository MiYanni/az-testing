# region Initialization
    # this module instance.
    $instance =  [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Module]::Instance

    # load nested script module if it exists
    if(Test-Path "$PSScriptRoot/bin/AppConfiguration.scripts.psm1") {
      Import-Module "$PSScriptRoot/bin/AppConfiguration.scripts.psm1"
    }

    $privatemodule = Import-Module -PassThru "$PSScriptRoot/bin/AppConfiguration.private.dll"
    # export the 'exported' cmdlets
    Get-ChildItem "$PSScriptRoot/exports" -Recurse -Filter "*.ps1" -File | Sort-Object Name | ForEach-Object {
      Write-Verbose "Dot sourcing private script file: $($_.Name)"
      . $_.FullName
      # Explicity export the member
      Export-ModuleMember -Function $_.BaseName
    }
# endregion

# region AzureInitialization
    # from PSModulePath
    # (this must be the modified version of Az.Accounts)

    $module = Get-Module Az.Accounts 
    if ($module -ne $null -and $module.Version.ToString().CompareTo("0.4.0") -lt 0) 
    { 
        Write-Error "This module requires Az.Accounts version 0.4.0. An earlier version of Az.Accounts is imported in the current PowerShell session. Please open a new session before importing this module. This error could indicate that multiple incompatible versions of the Azure PowerShell cmdlets are installed on your system. Please see https://aka.ms/azps-version-error for troubleshooting information." -ErrorAction Stop 
    } 
    elseif ($module -eq $null) 
    { 
        $module = Import-Module Az.Accounts -MinimumVersion 0.4.0 -Scope Global -passthru
    }

    Write-Host "Loaded Common Module '$($module.Name)'"

    # ask for the table of functions we can call in the common module.
    $VTable = Register-AzModule

    # delegate responsibility to the common module for tweaking the pipeline at module load
    $instance.OnModuleLoad = $VTable.OnModuleLoad

    # and a chance to tweak the pipeline when we are about to make a call.
    $instance.OnNewRequest = $VTable.OnNewRequest

    # Need to get parameter values back from the common module
    $instance.GetParameterValue = $VTable.GetParameterValue

    # need to let the common module listen to events from this module
    $instance.EventListener = $VTable.EventListener

    # get argument completers from the common module
    $instance.ArgumentCompleter = $VTable.ArgumentCompleter
# endregion

# region Finalization
    # finish initialization of this module
    $instance.Init();
  
# endregion
