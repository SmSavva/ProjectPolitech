from CountDown import CountDown, Subscriber1, Subscriber2
Timer = CountDown()
subscriber1 = Subscriber1()
subscriber2 = Subscriber2()
Timer.Subscribe(subscriber1)
Timer.Subscribe(subscriber2)
Timer.Timer(3, "3 seconds left")


