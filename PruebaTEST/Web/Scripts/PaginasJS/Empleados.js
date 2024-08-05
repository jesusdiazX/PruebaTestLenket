GetEmpleados();
GetEstados();

function GetEmpleados() {
    $.ajax({
        url: "/Empleado/getEmpledos",
        type: 'GET',
        dataType: 'json', // added data type
        success: function (res) {
            console.log(res);
            $('#tbody').empty();
            $.each(res, function (idx, obj) {
               
               
                var $tr = '<tr><td>' + obj.Id + '</td> ' + '<td>' + obj.NumeroNomina + '</td >' +
                    '<td>' + obj.Nombre + '</td>' + '<td>' + obj.ApellidoPaterno + '</td>' + '<td>' + obj.ApellidoMaterno + '</td>' + '<td> <button type="button" class="btn btn-primary" onclick="OpenModalActualiza(' + obj.Id + ');">Editar</button><button type="button" class="btn btn-danger" onclick="Delete(' + obj.Id +');">Eliminar</button></td></tr>'
                $('#tbody').append($tr);
            });



        }
    });
}

function GetEstados() {
    $.ajax({
        url: "/Empleado/GetEstados",
        type: 'GET',
        dataType: 'json', // added data type
        success: function (res) {


            console.log(res);
            $.each(res, function (idx, item) {
                $('#estado').append($('<option>', {
                    value: item.Id,
                    text: item.Estado
                }));
               // document.getElementById('tblEmpleado').insertRow(-1).innerHTML = '<td>' + obj.Id + '</td> ' + '<td>' + obj.NumeroNomina + '</td >' + '<td>' + obj.Nombre + '</td>' + '<td> <button type="button" class="btn btn-primary" onclick="genera_tabla()">Editt</button></td>'

            });



        }
    });
}

function OpenModal() {
    $('#Id').val(0);
    $('#empleadomodal').modal('show');
}
function OpenModalActualiza(id) {

    $.ajax({
        url: "/Empleado/getEmpledoId?id=" +id,
        type: 'GET',
        dataType: 'json', // added data type
        success: function (res) {

            $('#Id').val(res.Id);
            $('#Nombre').val(res.Nombre);
            $('#appat').val(res.ApellidoPaterno);
            $('#apmat').val(res.ApellidoMaterno);
            $('#estado').val(res.IdEstado);
            $('#numeroNom').val(res.NumeroNomina);
            $('#empleadomodal').modal('show');


        }
    });

 
   

 
}

function Gurarda() {

    var URL = "/Empleado/AddEmpledos";
    var URL0 = "/Empleado/Actualiza";
   var id= $('#Id').val();

    if (id == "0")
        URL = "/Empleado/AddEmpledos";
    else
        URL = "/Empleado/Actualiza";

    
    var data = {
        Id: parseInt(id),
        Nombre: $('#Nombre').val(),
        ApellidoPaterno: $('#appat').val(),
        ApellidoMaterno: $('#apmat').val(),        
        NumeroNomina: $('#numeroNom').val(),
        IdEstado: $('#estado').val()
    };

    console.log(data);



    $.ajax({
        url: URL,
        type: 'POST',
        dataType: 'json', // added data type
        data:data,
        success: function (res) {
            $('#empleadomodal').modal('hide');
            GetEmpleados();


        }
    });
}

function Delete(id) {


    var data = {
        Id: parseInt(id),
        Nombre: $('#Nombre').val(),
        ApellidoPaterno: $('#appat').val(),
        ApellidoMaterno: $('#apmat').val(),
        NumeroNomina: $('#numeroNom').val(),
        IdEstado: $('#estado').val()
    };

    console.log(data);



    $.ajax({
        url: "/Empleado/Delete",
        type: 'POST',
        dataType: 'json', // added data type
        data: data,
        success: function (res) {
           
            GetEmpleados();


        }
    });
}