document.addEventListener('DOMContentLoaded', function() {
    const boxes = document.querySelectorAll('.box');
    boxes.forEach(function(box) {
        box.addEventListener('click', function() {
            const currentSrc = box.getAttribute('src');
            if (currentSrc.includes('square.svg')) {
                box.setAttribute('src', 'images/square-check.svg');
            } else {
                box.setAttribute('src', 'images/square.svg');
            }
        });
    });
});
