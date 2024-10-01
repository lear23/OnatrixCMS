
    document.getElementById('submitEmail').addEventListener('click', function() {
        var emailInput = document.querySelector('.input-container input[type="text"]');
    var email = emailInput.value;

    if (email && validateEmail(email)) {
     
        window.location.href = `mailto:support@example.com?subject=Consult&body=Correo: ${email}`;
        } else {
        alert("Please, enter a valid email adress.");
        }
    });

  
    function validateEmail(email) {
        var re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return re.test(String(email).toLowerCase());
    }

