
//---------------------RISKFORM----------------------------

document.addEventListener("DOMContentLoaded", function () {
    const successMessage = document.getElementById('successRiskMessage');
    const contactForm = document.getElementById('riskForm');
    const backButton = document.getElementById('backBtn');

    if (successMessage) {
        window.scrollTo(0, successMessage.offsetTop);

        setTimeout(() => {
            successMessage.style.display = 'none';
            backButton.style.display = 'block';
            if (contactForm) {
                contactForm.reset();
            }


        }, 3000);
        window.location.href = '#riskForm';
        backButton.addEventListener('click', function () {
            successMessage.style.display = 'none';
            backButton.style.display = 'none';
            if (contactForm) {
                contactForm.reset();
            }
            
        });

    }
});

