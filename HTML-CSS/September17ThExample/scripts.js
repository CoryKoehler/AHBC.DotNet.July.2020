const calculatorGrid = document.querySelector('.calculator_grid')
const calculatorDisplay = document.querySelector('.calc_display')
const calculatorButtons = calculatorGrid.querySelector('.calc_buttons')
let firstValue = calculatorGrid.dataset.firstValue
let previousButton = calculatorGrid.dataset.previousButton
let operator = calculatorGrid.dataset.operator

calculatorButtons.addEventListener('click',event=>{
    if(event.target.matches('button')){
        const button = event.target
        const buttonContent = button.textContent
        const action = button.dataset.action
        const displayValue = calculatorDisplay.textContent
        determineAction(action, buttonContent, displayValue)
    }
});

function determineAction(action, buttonContent, displayValue){
    if(!action){
        if (displayValue === '0' || previousButton === 'operator') {
            calculatorDisplay.textContent = buttonContent
        } else {
            calculatorDisplay.textContent = displayValue + buttonContent
        }
    } else {
        if(action === 'add' || action === 'subtract' || action === 'multiply' || action === 'divide' ){
            calculatorGrid.dataset.previousButton = 'operator'
            firstValue = displayValue
            operator = action
            calculatorDisplay.textContent = '0'
        }
        if(action === 'equals'){
            let secondValue = displayValue
            calculatorDisplay.textContent = compute(parseFloat(firstValue), parseFloat(secondValue), operator)
        }
        if(action === 'clear'){
            firstValue = '0'
            previousButton = '0'
            calculatorDisplay.textContent = '0'
        }
    }
}

function compute(firstValue, secondValue, operator){
    let result = 0; 
    switch(operator){
        case 'add' :
            result = firstValue + secondValue
            break
        case 'subtract' :
            result = firstValue - secondValue
            break
        case 'divide' :
            result = firstValue / secondValue
            break
        case 'multiply' :
            result = firstValue * secondValue
            break
    }
    return result
}
