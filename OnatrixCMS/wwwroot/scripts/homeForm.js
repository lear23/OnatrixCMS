
//------------HOME FORM-------



document.addEventListener("DOMContentLoaded", function () {
    const successMessage = document.getElementById('successMessage');
    const contactForm = document.getElementById('homeForm');
    const backButton = document.getElementById('backButton2');

    if (successMessage) {
        window.scrollTo(0, successMessage.offsetTop);

        setTimeout(() => {
            successMessage.style.display = 'none';
            backButton.style.display = 'block';
            if (contactForm) {
                contactForm.reset();
            }


        }, 4000);
        window.location.href = '#requestForm';
        backButton.addEventListener('click', function () {
            successMessage.style.display = 'none';
            backButton.style.display = 'none';
            if (contactForm) {
                contactForm.reset();
            }
            window.location.href = '/';
        });

    }
});