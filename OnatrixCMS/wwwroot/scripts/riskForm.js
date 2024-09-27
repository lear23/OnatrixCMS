
//---------------------RISKFORM----------------------------

//document.addEventListener("DOMContentLoaded", function () {
//    const successMessage = document.getElementById('successRiskMessage');
//    const contactForm = document.getElementById('riskForm');
//    const backButton = document.getElementById('backBtn');

//    if (successMessage) {
//        window.scrollTo(0, successMessage.offsetTop);

//        setTimeout(() => {
//            successMessage.style.display = 'none';
//            backButton.style.display = 'block';
//            if (contactForm) {
//                contactForm.reset();
//            }


//        }, 3000);
//        window.location.href = '#riskForm';
//        backButton.addEventListener('click', function () {
//            successMessage.style.display = 'none';
//            backButton.style.display = 'none';
//            if (contactForm) {
//                contactForm.reset();
//            }

//        });

//    }
//});

document.addEventListener("DOMContentLoaded", function () {
    const successMessage = document.getElementById('successRiskMessage');
    const contactForm = document.getElementById('riskForm');

    if (successMessage && successMessage.innerHTML.trim() !== "") {
        // Mostrar el mensaje de éxito
        successMessage.style.display = 'block';

        // Reiniciar los campos del formulario
        if (contactForm) {
            contactForm.querySelector('input[name="Name"]').value = '';
            contactForm.querySelector('input[name="Email"]').value = '';
            contactForm.querySelector('textarea[name="Message"]').value = '';
        }

        // Desplazar la vista hacia el mensaje de éxito
        window.scrollTo(0, successMessage.offsetTop);

        // Ocultar el mensaje después de 3 segundos
        setTimeout(() => {
            successMessage.style.display = 'none';
        }, 5000);
    }
});




