bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *
import unittest
    
class SmokeTests(unittest.TestCase):

    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
        
    def test_001_GoogleSearch(self):
        LaunchBrowser("chrome", "www.google.com")
        type(GoogleMap.google_search_input, "Telerik academy")
        wait(GoogleMap.google_telerik_link, 10)
        assert exists(GoogleMap.google_telerik_link)

    def test_002_DragAndDrop(self):
        LaunchBrowser("chrome", "http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html")
        dragDrop(CapitalsMap.oslo, CapitalsMap.norway)
        dragDrop(CapitalsMap.stockholm, CapitalsMap.sweden)
        dragDrop(CapitalsMap.washington, CapitalsMap.us)
        dragDrop(CapitalsMap.copenhagen, CapitalsMap.denmark)
        dragDrop(CapitalsMap.seoul, CapitalsMap.southKorea)
        dragDrop(CapitalsMap.rome, CapitalsMap.italy)
        dragDrop(CapitalsMap.madrid, CapitalsMap.spain)
        assert exists(CapitalsMap.correctRome)
        assert exists(CapitalsMap.correctMadrid)
        assert exists(CapitalsMap.correctOslo)
        assert exists(CapitalsMap.correctCopenhagen)
        assert exists(CapitalsMap.correctSeoul)
        assert exists(CapitalsMap.correctStockholm)
        assert exists(CapitalsMap.correctWashington)
        
    def test_003_CalculatorFunctionsCorrectly(self):
        LaunchCalculator();
        click(CalculatorMap.two)
        click(CalculatorMap.subtract)
        click(CalculatorMap.four)
        click(CalculatorMap.equals)
        assert exists(CalculatorMap.subtractionResult)

        click(CalculatorMap.multiply)
        click(CalculatorMap.three)
        click(CalculatorMap.equals)
        assert exists(CalculatorMap.multiplyResult)

        click(CalculatorMap.add)
        click(CalculatorMap.one)
        click(CalculatorMap.one)
        click(CalculatorMap.equals)
        assert exists (CalculatorMap.additionResult)

        click(CalculatorMap.divide)
        click(CalculatorMap.two)
        click(CalculatorMap.equals)
        assert (CalculatorMap.divisionResult)

        click(CalculatorMap.divide)
        click(CalculatorMap.zero)
        assert exists(CalculatorMap.divisionByZeroMessage)

class Tests(unittest.TestCase):

    def setUp(self):
        pass
    
    def tearDown(self):
        pass 
    
    def test_003_CalculatorFunctionsCorrectly(self):
        LaunchCalculator();
        click(CalculatorMap.two)
        click(CalculatorMap.subtract)
        click(CalculatorMap.four)
        click(CalculatorMap.equals)
        assert exists(CalculatorMap.subtractionResult)

        click(CalculatorMap.multiply)
        click(CalculatorMap.three)
        click(CalculatorMap.equals)
        assert exists(CalculatorMap.multiplyResult)

        click(CalculatorMap.add)
        click(CalculatorMap.one)
        click(CalculatorMap.zero)
        click(CalculatorMap.equals)
        assert exists (CalculatorMap.additionResult)

        click(CalculatorMap.divide)
        click(CalculatorMap.two)
        click(CalculatorMap.equals)
        assert exists(CalculatorMap.divisionResult)

        click(CalculatorMap.divide)
        click(CalculatorMap.zero)
        click(CalculatorMap.equals)
        assert exists(CalculatorMap.divisionByZeroMessage)
        
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(Tests)
    
   
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report')
    runner.run(suite)
outfile.close()

