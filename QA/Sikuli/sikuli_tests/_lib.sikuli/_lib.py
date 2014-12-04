from sikuli import *
import HTMLTestRunner
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *

def LaunchBrowser(browser, url):
    sleep(0.5)
    type("d", KEY_WIN)
    sleep (1)
    type("r", KEY_WIN)
    sleep(1)
    type(browser+" ")
    sleep(1)
    type(url)
    sleep(1)
    type(Key.ENTER)

def LaunchCalculator():
    sleep(0.5)
    type("d", KEY_WIN)
    sleep (1)
    type("r", KEY_WIN)
    sleep(1)
    type("calc")
    sleep(1)
    type(Key.ENTER)
