.PHONY: all version_select cat64 cat32

all: version_select cat64 cat32

cat64:
	xbuild /target:WifiCat /p:TargetFrameworkVersion="v4.0" /p:Configuration=Release /p:Platform=x64 /p:WarningLevel=0 /verbosity:full
	mkdir -p out
	cp -v WifiCat/bin/x64/Release/WifiCat.exe out/wificat_windows_x64.exe

cat32:
	xbuild /target:WifiCat /p:TargetFrameworkVersion="v4.0" /p:Configuration=Release /p:Platform=x86 /p:WarningLevel=0 /verbosity:full
	mkdir -p out
	cp -v WifiCat/bin/x86/Release/WifiCat.exe out/wificat_windows_x86.exe

version_select:
	xbuild /target:"Wifi Cat Version Selector" /p:TargetFrameworkVersion="v4.0" /p:Configuration=Release /p:Platform="Any CPU" /p:WarningLevel=0 /verbosity:full
	mkdir -p out
	cp -v Wifi\ Cat\ Version\ Selector/bin/Release/Wifi\ Cat\ Version\ Selector.exe out/wificat_version_select_windows.exe

edit_url:
	editor + Wifi\ Cat\ Version\ Selector/Properties/Resources.resx
