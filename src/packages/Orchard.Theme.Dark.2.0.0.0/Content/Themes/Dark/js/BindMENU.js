(function(a){a.fn.BindMENU=function(b){a("ul",this).addClass("submenu");if(a.browser.msie&&parseInt(a.browser.version,10)==7){a("ul.submenu",this).before('<div style="height: 0px; line-height: 0px; clear: both; overflow: hidden; font-size:0px; position:fixed" />')}if((b.Orientation.toLowerCase()=="horizontal"&&b.MenuStyle.toLowerCase()=="accordion")||b.MenuStyle.toLowerCase()=="defaultmenu"){a("ul.submenu",this).hide().css("position","absolute");var d=a(this);a("li",this).hover(function(){if(a(this).find("ul").is(".submenu")){var i=a(this).find("ul.submenu");if(b.Orientation.toLowerCase()=="vertical"||a(this).parent().is(".submenu")){i.css("left",i.parent().outerWidth(true));a(this).css("position","relative");var g=a(this).children("a").offset().top-a(this).offset().top;g=g+a(this).children("a").outerHeight(true);i.css("margin-top","-"+g+"px");i.css("margin-left","0px");var f=a(this).offset().left+a(this).outerWidth(true);if(f+i.outerWidth()>a(window).width()){i.css("left","0px").css("left","-"+i.outerWidth()+"px")}}else{var h=a(this).children("a,span").offset().left-a(this).offset().left;if(h>0){i.css("margin-left","-"+h+"px")}var e=a(this).children("a,span").offset().top-a(this).offset().top;if(e>0){i.css("margin-top",e+"px")}}}a("ul:first",this).slideDown("fast")},function(){a("ul:first",this).hide()})}if(b.Orientation.toLowerCase()=="vertical"&&b.MenuStyle.toLowerCase()=="accordion"){a(this).closest("#MenuV").addClass("accordion");a(this).children("li").children("ul").hide();a(this).children("li").hover(function(e){e.stopPropagation();if(a(this).children("ul").is(".submenu")){a(this).children("ul").find("ul").show();a(this).children("ul").slideDown("fast")}},function(e){e.stopPropagation();if(a(this).children("ul").is(".submenu")){a(this).children("ul").slideUp("fast")}})}if(b.MenuStyle.toLowerCase()=="megamenu"){a(this).parent().addClass("megamenu");a(".submenu",this).css("display","block");var c=a(this).parent().offset().left+a(this).parent().outerWidth(true);a(this).children("li").children("ul").each(function(){if(a(this).children("li").children("ul").is(".submenu")){a(this).parent().addClass("mega");var e=a(this).outerWidth()-a(this).width();var f="0";a(this).css("position","absolute");a(".submenu",this).css("display","block");a(this).children("li").css("display","block").css("float","left");a(this).children("li").each(function(){e+=a(this).outerWidth(true);if(a(this).outerHeight(true)>f){f=a(this).outerHeight(true)}});a(this).children("li").css("min-height",f+"px");a(this).css("min-width",e)}});a(this).children("li").children("ul").hide();a(this).children("li").hover(function(){if(a(this).children("ul").is(".submenu")){var i=a(this).children("ul.submenu");i.css("position","absolute");if(b.Orientation.toLowerCase()=="vertical"){i.css("left",i.parent().outerWidth(true));a(this).css("position","relative");var g=a(this).children("a").offset().top-a(this).offset().top;g=g+a(this).children("a").outerHeight(true);i.css("margin-top","-"+g+"px");i.css("margin-left","0px");var f=a(this).offset().left+a(this).outerWidth(true);if(f+i.outerWidth()>a(window).width()){i.css("left","0px").css("left","-"+i.outerWidth()+"px")}}else{var h=a(this).find("a,span").offset().left-a(this).offset().left;if(h>0){i.css("margin-left","-"+h+"px")}var e=a(this).find("a,span").offset().top-a(this).offset().top;if(e>0){i.css("margin-top",e+"px")}if(b.Orientation.toLowerCase()=="horizontal"){var j=a(this).offset().left+i.outerWidth();if(c<j){var g=j-c;i.css("margin-left",h-g+"px")}}}}a("ul:first",this).slideDown("fast")},function(){a("ul:first",this).hide()})}}})(jQuery);