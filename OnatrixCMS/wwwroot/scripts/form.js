
//------------------------FORM----------------------


document.addEventListener("DOMContentLoaded", function () {
    const successMessage = document.getElementById('successMessage');
    const contactForm = document.getElementById('contactForm');
    const backButton = document.getElementById('backButton');

    if (successMessage) {
        window.scrollTo(0, successMessage.offsetTop);

        setTimeout(() => {
            successMessage.style.display = 'none';
            backButton.style.display = 'block'; 
            if (contactForm) {
                contactForm.reset();               
            }
            
           
        }, 4000);
        window.location.href = '#myForm'; 
        backButton.addEventListener('click', function () {
            successMessage.style.display = 'none';
            backButton.style.display = 'none'; 
            if (contactForm) {
                contactForm.reset(); 
            }
            window.location.href = '/contact'; 
        });
       
    }
});



