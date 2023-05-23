try {
    const toggleBtn = document.querySelector('[data-option="toggle"]')
    toggleBtn.addEventListener('click', function () {
        const element = document.querySelector(toggleBtn.getAttribute('data-target'))

        if (!element.classList.contains('open-menu')) {
            element.classList.add('open-menu')
            toggleBtn.classList.add('btn-outline-dark')
            toggleBtn.classList.add('btn-toggle-white')
        }

        else {
            element.classList.remove('open-menu')
            toggleBtn.classList.remove('btn-outline-dark')
            toggleBtn.classList.remove('btn-toggle-white')
        }
    })
} catch { }


try {
    const footer = document.querySelector('footer')

    if (document.body.scrollHeight >= window.innerHeight) {
        footer.classList.remove('position-fixed')
        footer.classList.add('position-static')
    } else {
        footer.classList.remove('position-static')
        footer.classList.add('position-fixed')
    }
}
catch { }


const validateEmail = (event) => {
    const regExEmail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/

    if (regExEmail.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid E-mailaddress, eg. name@domain.com"

    }  
}

const validateName = (event) => {

    if (event.target.value.length >= 2) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Your Name must contain 2 letters"

    }
}

const validateFirstName = (event) => {

    if (event.target.value.length >= 2) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Your First Name must contain 2 letters"

    }
}

const validateLastName = (event) => {

    if (event.target.value.length >= 2) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Your Last Name must contain 2 letters"

    }
}

const validateMessage = (event) => {

    if (event.target.value.length >= 3) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Enter a message containing more than 3 letters"

    }
}

const validateRegisterPassword = (event) => {
    const regExPassword = /^(?=.*[A-Z])(?=.*[\W_])[A-Za-z\W_]{8,}$/

    if (regExPassword.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Your password need to contain one uppercase letter, one special character and be at least 8 characters long"

    }
}


const validateProductNumber = (event) => {
    
    if (event.target.value.length >= 1) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "You need to enter a Product Number"

    }
}

const validateProductName = (event) => {
    
    if (event.target.value.length >= 2) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Enter a Product Name containing more than 1 letter"

    }
}

const validateProductPrice = (event) => {
    
    if (event.target.value.length >= 1) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "You need to enter a Price, only numbers"

    }
}

const validateProductImage = (event) => {

    if (event.target.value.length >= 10) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    }
    else {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "You need to enter Product image"

    }
}