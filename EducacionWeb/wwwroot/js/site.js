// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function login() {
    const usuarioActual = document.getElementById("usuario").value;
    const password = document.getElementById("password").value;

    if (usuarioActual === "admin" && password === "admin") {
        alert("Bienvenido usuario: " + usuarioActual);
    } else {
        alert("datos incorrectos, reintente");
    }
}


function limpiarCampos() {
    let inputs = document.querySelectorAll('input');
    inputs.forEach(input => {
        input.value = '';
    });
}