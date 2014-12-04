########################################################
# UI map for XYZ
########################################################
from sikuli import *
########################################################

class GoogleMap:
    google_search_input = "google-search-input.png"
    google_telerik_link = "google-telerik-link.png"

class CapitalsMap:
    oslo = "oslo.png"
    stockholm = "stockholm.png"
    washington = "washington.png"
    copenhagen = "copenhagen.png"
    seoul = "seoul.png"
    rome = "rome.png"
    madrid = "madrid.png"
    italy = "italy.png"
    spain = "spain.png"
    norway = "norway.png"
    denmark = "denmark.png"
    southKorea = "south-korea.png"
    sweden = "sweden.png"
    us = "us.png"
    correctRome = "rome-italy.png"
    correctMadrid = "spain-madrid.png"
    correctOslo = "norway-oslo.png"
    correctCopenhagen = "denmark-copenhagen.png"
    correctSeoul = "south-korea-seoul.png"
    correctStockholm = "sweden-stockholm.png"
    correctWashington = "us-washington.png"

class CalculatorMap:
    add = Pattern("add.png").similar(0.94)
    subtract = Pattern("subtract.png").similar(0.97)
    multiply = Pattern("multiply.png").similar(0.89)
    divide = Pattern("divide.png").similar(0.95)
    zero = Pattern("zero.png").similar(0.78)
    one = Pattern("one.png").similar(0.87)
    two = Pattern("two.png").exact()
    three = Pattern("three.png").similar(0.97)
    four = Pattern("four.png").similar(0.93)
    equals = Pattern("equals.png").similar(0.79)
    subtractionResult = "subtraction-result.png"
    multiplyResult = "multiplyResult.png"
    additionResult = "add-result.png"
    divisionResult = "div-result.png"
    divisionByZeroMessage = "division-by-zero-message.png"
    
