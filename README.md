# Process-Management
模拟单处理器系统的进程调度，采用基于时间片多队列反馈式调度策略调度策略。共有3个优先级。
进程有空闲（新）、就绪、运行、阻塞和完成5个状态。能够模拟进程从生到灭的完整过程。

采用C#语言编写。共有3个窗口。
第一个是系统配置窗口，规定了系统中各种的资源的数量，以及各个优先级的时间片。这些内容可以从配置中读取，也可以由用户手工输入。
第二个为主窗口，系统的调度都显示在这个窗口，设立3个优先级。默认情况下，系统采用基于时间片多队列反馈式调度策略调度策略。用户可以手工阻塞进程或者让已经阻塞的进程就绪。运行结果实时显示，并可以保存到文件中。
第三个是新建进程窗口，用户手工指定进程名称以及所需要的资源，以及是否需要I/O操作。


1、可以预先设置好各进程的总的运行时间、I/O时间、I/O发生的时刻等信息，之后操作系统控制进程运行，实现状态切换，直到全部进程完成。
2、亦可以采用人工干预方式控制进程状态切换。
3、具有对用户输入容错的能力。
