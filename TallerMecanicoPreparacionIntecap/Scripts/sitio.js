function mostrar_alerta(parametro,tipoAlerta)
{
    console.log(parametro);
    let alerta = document.querySelector(tipoAlerta);
    console.log(alerta);
    alerta.firstElementChild.innerText = parametro;
    alerta.style.display = 'block';
    setTimeout(()=>alerta.remove(),4000);
}
function limpiar_textos()
{
    console.log("limpiando");
    const textos = document.querySelectorAll('input[type=text]');
    for (let i = 0; i < textos.length; i++) {
        console.log(textos[i].innerText);
        textos[i].value = '';
    }
}
