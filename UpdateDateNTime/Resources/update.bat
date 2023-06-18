sc config w32time start=auto
net start w32time
w32tm /config /manualpeerlist:time.windows.com /syncfromflags:manual /reliable:yes /update