// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
	var slides = $('.slides'),
images = slides.find('img');

images.each(function (i) {
	$(this).attr('data-id', i + 1);
	})

var typed = new Typed('.typed-words', {
	strings: ["Sentimente.", "Visuri.", "Povești.", "Cărți.", "Evenimente."],
typeSpeed: 50,
backSpeed: 50,
backDelay: 3000,
startDelay: 2000,
loop: true,
showCursor: true,
		preStringTyped: (arrayPos, self) => {
	arrayPos++;
console.log(arrayPos);
$('.slides img').removeClass('active');
$('.slides img[data-id="' + arrayPos + '"]').addClass('active');
		}

	});
})