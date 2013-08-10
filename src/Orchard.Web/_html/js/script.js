jQuery(document).ready(function(){
	$('input, textarea').placeholder();
	
	Cufon.replace('nav ul li a', { fontFamily: 'Arial Narrow', hover: true });
	Cufon.replace('.exercise-table td,.narrow,.services-box-content,.services-box-title,.services-find-out-more,.services-price,.services-container-title span,.services-body p,.services-gold-content-title,.services-gold-content-body,.q-more-details,.qualifications-box-title,.qualifications-box-content,h1, h2, h3, h4, #staticText p, .testimonials-box-title,.testimonials-box-content,.standard2-left-column,.standard2-left-column,.li-left,.standard1-body,#login-form form span,#mailing-form form span,#contact-box p,#contact-box span,#testimonial-content p,#testimonial-content span', { fontFamily: 'Arial Narrow' });
	
	  $('nav li').hover(
        function () {
            $('a:first',this).addClass("subhover");
            //show its submenu
            var h = $(this).find("a").outerHeight();
            
            $('ul', this).css('top',$(this).find("a").position().top+h);
            $('ul', this).css('left',$(this).find("a").position().left).stop().slideDown(100);
 
        },
        function () {
            $('a:first',this).removeClass("subhover");
            //hide its submenu
            $('ul', this).stop().slideUp(100);         
        }
    );
    
    $('.see-video').click(function() {
          $.fancybox({
              'padding'       : 0,
              'autoScale'     : false,
              'transitionIn'  : 'none',
              'transitionOut' : 'none',
              'title'         : this.title,
              'width'         : 640,
              'height'        : 385,
              'href'          : this.href.replace(new RegExp("watch\\?v=", "i"), 'v/'),
              'type'          : 'swf',
              'swf'           : {
              'wmode'             : 'transparent',
              'allowfullscreen'   : 'true'
              }
          });
   
          return false;
      });
	
});



