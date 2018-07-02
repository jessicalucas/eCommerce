Listar();
Totalizador();

function Listar() {
    LimparFormulario();
    $.ajax({
        type: "GET",
        url: "/ItemProduto/Listar",
        success: function (dadosCarrinho) {
            if (dadosCarrinho != null) {
                $('#tbody').children().remove();
                $(dadosCarrinho).each(function (i) {
                    var tbody = $('#tCar');
                    var tr = "<tr>";
                    tr += "<td>" + dadosCarrinho[i].Item.NOME;
                    tr += "<td>" + "<button onclick=Diminuir(" + dadosCarrinho[i].Item.ID_PRODUTO + ")>" + " - " + "</button>"
                        + "<input type='number' id='quantidade" + dadosCarrinho[i].Item.ID_PRODUTO + "' value='0' maxlength = '2' min='1' readonly='true'/>"
                        + "<button onclick=Aumentar(" + dadosCarrinho[i].Item.ID_PRODUTO + ")>" + " + " + "</button>";

                    tr += "<td>" + "<input id='total" + dadosCarrinho[i].Item.ID_PRODUTO + "'value='0' readonly='true' class='valor-calculado'/>"
                    tr += "<td>" + dadosCarrinho[i].Item.Promocao.DESC_PROMO;
                    tbody.append(tr);
                });
            }
        }
    });
}

function Aumentar(idProduto) {

    var v = document.getElementById("quantidade" + idProduto);
    var pp = parseInt(v.value);
    if (pp >= 0 && pp < 100)
        v.value = pp + 1;

    Atualizar(idProduto, v.value);
}

function Diminuir(idProduto) {


    var v = document.getElementById("quantidade" + idProduto);
    var pp = parseInt(v.value);
    if (pp > 0)
        v.value = pp - 1;

    Atualizar(idProduto, v.value);

}

function Atualizar(idProduto, qtd) {

    $.ajax({
        type: "POST",
        url: "/ItemProduto/Atualizar",
        data: { id: idProduto, quantidade: qtd },
        success: function (valorAPagar) {
            var v = document.getElementById("total" + idProduto);
            v.value = valorAPagar;
            Totalizador(valorAPagar);
        },
        error: function myfunction() {
            alert("Erro!");
        }

    });
}

function LimparFormulario() {
    $('#formDados').each(function () {
        this.reset();
    });
}

function Totalizador(valorAPagar) {

    var els = document.getElementsByClassName("valor-calculado");
    var valorcalculado = 0.00;
    var yesye = parseInt(valorAPagar);
    [].forEach.call(els, function (el) {
        var val = parseFloat(el.value);
        valorcalculado += val;
    });

    $("#Totalizador").val(valorcalculado);
}