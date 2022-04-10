import unittest
from CountDown import CountDown, Subscriber1, Subscriber2

class TestCounDown(unittest.TestCase):
    def testTextSubscriber1(self):
        timer = CountDown()
        sub = Subscriber1()
        timer.Subscribe(sub)
        timer.Timer(4, '4 seconds left')
        self.assertEqual(sub.GetText(), '4 seconds left')

    def testTextSubscriber2(self):
        timer = CountDown()
        sub = Subscriber2()
        timer.Subscribe(sub)
        timer.Timer(5, '5 seconds left')
        self.assertEqual(sub.GetText(), '5 seconds left')
    
    def testRemoveSubscriber1(self):
        timer = CountDown()
        sub = Subscriber1()
        timer.Subscribe(sub)
        timer.RemoveSibescriber(sub)
        timer.Timer(4, '4 seconds left')
        self.assertEqual(sub.GetText(), "")

    def testRemoveSubscriber2(self):
        timer = CountDown()
        sub = Subscriber2()
        timer.Subscribe(sub)
        timer.RemoveSibescriber(sub)
        timer.Timer(4, '4 seconds left')
        self.assertEqual(sub.GetText(), "")
    
    def testMessageIsNull(self):
        timer = CountDown()
        sub = Subscriber1()
        timer.Subscribe(sub)
        with self.assertRaises(ValueError): timer.Timer(10, None)
    
    def testTimeIsLess(self):
        timer = CountDown()
        sub = Subscriber1()
        timer.Subscribe(sub)
        with self.assertRaises(ValueError): timer.Timer(-1, 'something')
    
    def testMoreSubcribers(self):
        timer = CountDown()
        sub1 = Subscriber1()
        sub2 = Subscriber2()
        timer.Subscribe(sub1)
        timer.Subscribe(sub2)
        timer.Timer(5, "Caboom")
        self.assertEqual([sub1.GetText(),sub2.GetText()], ['Caboom','Caboom'])
        
    def testNoSubscribers(self):
        timer = CountDown()
        self.assertEqual(timer.Timer(2, "No subscribers"),None)

if __name__ == "__main__": unittest.main(verbosity=2)