
document.addEventListener("DOMContentLoaded", function () {
    const successMessage = document.getElementById('successRiskMessage');
    const contactForm = document.getElementById('riskForm');

    if (successMessage && successMessage.innerHTML.trim() !== "") {
       
        successMessage.style.display = 'block';

        if (contactForm) {
            contactForm.querySelector('input[name="Name"]').value = '';
            contactForm.querySelector('input[name="Email"]').value = '';
            contactForm.querySelector('textarea[name="Message"]').value = '';
        }

        window.scrollTo(0, successMessage.offsetTop);

        
        setTimeout(() => {
            successMessage.style.display = 'none';
        }, 5000);
    }
});




