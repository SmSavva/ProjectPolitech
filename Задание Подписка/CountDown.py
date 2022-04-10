import time
from zope.interface import Interface, implementer

class ISubscriber(Interface):
    def Display(text: str): 
        """Display text"""

class ICountDown(Interface):
    def Subscribe(sub: ISubscriber ): 
        """Add subscriber"""
    def RemoveSubscriber(sub: ISubscriber):
        """Remove subscriber"""
    def Timer(ms: int, message: str):
        """Add time """

@implementer(ICountDown)
class CountDown:
    def __init__(self):
        self.events = list()

    def Subscribe(self, sub: ISubscriber):
        self.events.append(sub)
    
    def RemoveSibescriber(self, sub: ISubscriber):
        self.events.remove(sub)
    
    def Timer(self, ms, message):
        if ms<0: raise ValueError("time less then 0")
        else:
            time.sleep(ms)
            for EventCallback in self.events:
                EventCallback.Display(message)

@implementer(ISubscriber)
class Subscriber1:
    def __init__(self):
        self.text = ""
    def Display(self, text):
        self.text = text
        if text == None:
            raise ValueError("message argument is null")
        else:
            print(" Subscriber1 ({0}): Message".format(text))
    def GetText(self):
        return self.text

@implementer(ISubscriber)
class Subscriber2:
    def __init__(self):
        self.text = ""
    def Display(self, text):
        self.text = text
        if text == None:
            raise ValueError("message argument is null")
        else:
            print(" Subscriber2 ({0}): Message".format(text))
    def GetText(self):
        return self.text