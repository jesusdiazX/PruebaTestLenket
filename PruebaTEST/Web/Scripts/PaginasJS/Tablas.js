
function genera_tabla() {
    
    var contenedor = document.getElementById("main");

    var num = $("#texto").val();

    


  // Crea un elemento <table> y un elemento <tbody>
    var tabla = document.createElement("table");
    tabla.className = "table";
  var tblBody = document.createElement("tbody");
  
    // Crea las celdas
    for (var i = 1; i < parseInt(num) +1; i++) {
    // Crea las hileras de la tabla
    var hilera = document.createElement("tr");

        for (var j = 1; j < parseInt(num) +1; j++) {
      // Crea un elemento <td> y un nodo de texto, haz que el nodo de
      // texto sea el contenido de <td>, ubica el elemento <td> al final
      // de la hilera de la tabla
      var celda = document.createElement("td");
        var btn = document.createElement("button");
        btn.innerText = "click";
            btn.className = "btn btn-block";
            btn.type = "subbmit";
            btn.id = "button1";
            btn.id = "button1";
            btn.dataset.dateOfBirth= "Fila: "+i +"  Columna: " +j;
        celda.appendChild(btn);
      hilera.appendChild(celda);
    }
    tblBody.appendChild(hilera);
  }

  tabla.appendChild(tblBody);
    contenedor.appendChild(tabla);
  tabla.setAttribute("border", "2");
}

$(document).ready(function () {
   
    $(document).on('click', '#button1', function () {

        
        var $btn = this;
        console.log($btn);

        $("#Result").val($btn.dataset.dateOfBirth);
    });

  
});


function valideKey(evt) {
   
 
    var code = (evt.which) ? evt.which : evt.keyCode;
    if (code == 8) { 
        return true;
    } else if (code >= 48 && code <= 57) { 
        return true;
    } else { 
        return false;
    }
}

