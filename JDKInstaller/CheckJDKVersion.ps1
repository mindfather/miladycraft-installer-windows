$jdkVersion = Get-ItemPropertyValue -Path 'HKLM:\SOFTWARE\JavaSoft\JDK' -Name 'CurrentVersion' -ErrorAction SilentlyContinue

if ($jdkVersion -and $jdkVersion -ge '21' -and $jdkVersion -lt '22') {
	Write-Output "0" # Don't install JDK
} else {
	Write-Output "1" # Install JDK
}
