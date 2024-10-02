// --------------------Services-----------------

document.addEventListener("DOMContentLoaded", function () {
    window.addEventListener('scroll', function () {
        var servicesSection = document.querySelector('.services');
        if (servicesSection) {
            var servicesH5 = document.querySelector('.services h5');
            var servicesH1 = document.querySelector('.services h1');
            var servicesPosition = servicesSection.getBoundingClientRect().top;
            var screenPosition = window.innerHeight / 1.1;

            if (servicesPosition < screenPosition && servicesPosition > -servicesSection.offsetHeight) {
                servicesH5.classList.add('animate');
                servicesH1.classList.add('animate');
            } else {
                servicesH5.classList.remove('animate');
                servicesH1.classList.remove('animate');
            }
        }
    });
});




// -------------------------video------------------------------


const video = document.querySelector('.responsive-video');


video.addEventListener('mouseover', function() {
    video.play();
});

video.addEventListener('mouseout', function() {
    video.pause();
});

function isInViewport(element) {
    const rect = element.getBoundingClientRect();
    return (
        rect.top >= 0 &&
        rect.left >= 0 &&
        rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
        rect.right <= (window.innerWidth || document.documentElement.clientWidth)
    );
}
window.addEventListener('scroll', function() {
    if (isInViewport(video)) {
        video.play();
    } else {
        video.pause();
    }
});



