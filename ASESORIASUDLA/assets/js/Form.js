(function(){
    $(document).ready(function(){
        $('.alt-form').click(function(){
            $('.form-content').animate({
                height: "toggle",
                opacity: 'toggle'
            }, 600);
        });

        let formRegistro = document.getElementsByName('form-input-login');
        for (let i = 0; i < formRegistro.length; i++) {
            formRegistro[i].addEventListener('blur', function(){
                if (this.value.length >= 1) {
                    
                    this.classList.add('active-2'); // BORDE
                    this.classList.remove('error-2');
                    
                    this.nextElementSibling.classList.add('active');
                    this.nextElementSibling.classList.remove('error');
                    
                    this.previousElementSibling.classList.add('active-3'); // ICONO
                    this.previousElementSibling.classList.remove('error-3');
                    
                } else if (this.value.length = " ") {
                    
                    this.classList.add('error-2'); // BORDE
                    this.classList.remove('active-2');
                    
                    this.nextElementSibling.classList.add('error');
                    this.nextElementSibling.classList.remove('active');
                    
                    this.previousElementSibling.classList.remove('active-3'); // ICONO
                    this.previousElementSibling.classList.add('error-3');
                    
                } else {
                    this.nextElementSibling.classList.remove('active');
                    this.classList.remove('active-2');
                }
            });
        }

    });
}());


