Get-ChildItem -Recurse -Force -Directory -Include 'bin' |
Remove-Item -Recurse -Confirm:$false -Force