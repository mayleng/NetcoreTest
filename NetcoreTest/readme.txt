目前Windows server 2012r2 和 centos7上安装了2.0 2.1 2.2版本的netcore SDK

所以目前只有这两个系统能运行这三个网站

Ubuntu17.04只安装了netcore2.0的SDK

在Windows server2012r2上直接输入dotnet run 即可启动这三个网站。

在centos中建立的相关版本SDK的软连接，所以启动不同版本的项目可以通过相应的连接来启动：
如： dotnet  run           启动2.0项目
     dotnet2.1  run        启动2.1项目
     dotnet2.2  run        启动2.2项目