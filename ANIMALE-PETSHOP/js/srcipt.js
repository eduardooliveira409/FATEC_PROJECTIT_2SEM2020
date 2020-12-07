$('.cadastro').click(function(){
  //toggleClass - Muda o nome da class
  $('.menu-lateral ul .itens-cadastro').toggleClass('mostra');
  $('.menu-lateral ul .seta1').toggleClass('rotaciona');
});

$('.agendamento').click(function(){
  $('.menu-lateral ul .itens-agenda').toggleClass('mostra');
  $('.menu-lateral ul .seta2').toggleClass('rotaciona');
})

$('.btnAbre').click(function () {
  $('.menu-lateral').toggleClass('mostra');
});

$('.btnFecha').click(function () {
  $('.menu-lateral').toggleClass('mostra');
});

const $menuLateral = $('.menu-lateral');
$(document).mouseup(e => {
  if(!$menuLateral.is(e.target) && $menuLateral.has(e.target).length === 0)
  {
    $menuLateral.removeClass('mostra');
  }
});