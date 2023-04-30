<template>
    <div class="card">
        <div>
            <div class="title-perfil">
                <i class="fa-solid fa-user icones"></i>
                PERFIL
            </div>
        </div>
        <div class="card-form">
            <div style="width: 100%;row-gap: 1rem; display:flex; flex-direction: column;">
            <div class="input-labels">
                <input disabled placeholder="Razão Social" class="input" value="Jéssica e Isabel Informática Ltda"/>
            </div>
            <div class="input-labels">
                <input disabled placeholder="CNPJ" class="input"  value="49.639.688/0001-43"/>
            </div>
            <div class="input-labels">
                <input disabled placeholder="Telefone" class="input" />
            </div>
            <div class="input-labels">
                <input disabled placeholder="E-mail" class="input" value="pesquisa@jessicaeisabelinformaticaltda.com.br"/>
            </div>
            <div class="input-labels">
                <input disabled placeholder="Responsável" class="input" />
            </div>
            <div class="input-labels">
                <input disabled placeholder="CPF" class="input"/>
            </div>
        </div>
            <div style="width: 100%;row-gap: 1rem; display:flex; flex-wrap: wrap;">
                <div class="input-labels">
                    <input disabled placeholder="Endereço" class="input" value="Rua Minas Gerais"/>
                </div>
                <div class="input-labels">
                    <input disabled placeholder="Numero" class="input"  value="540"/>
                </div>
                <div class="input-labels">
                    <input disabled placeholder="Complemento" class="input"/>
                </div>
                <div class="input-labels">
                    <input disabled placeholder="Bairro" class="input" />
                </div>
                <div class="input-labels-cidade">
                    <div class="input-labels">
                        <input disabled placeholder="Cidade" class="input" value="Guarujá"/>
                    </div>
                    <div class="input-labels">
                        <input disabled placeholder="Estado" class="input"  value="SP"/>
                    </div>
                </div>
                <div class="input-labels">
                    <input disabled placeholder="Cep" class="input" value="11436-160" />
                </div>
            </div>
        </div>
    </div>
</template>

<style scoped>
.input-labels-cidade{
    display: flex;
    width: 100%;
    column-gap: 1rem;
}
.input-labels{
    display: flex;
    width: 100%;
}
.card-form{
    display: flex;
    column-gap: 1rem;
}
.title-perfil{
        padding-bottom: 1rem;
        display: flex;
        align-items: center;
        gap: 1rem;
            font-size: 25px ;
            text-decoration: none;
          font-weight: bold;
          font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    }

    .icones{
        font-size: 50px;
}
.card{
    background: white;
    display: flex;
    border-radius: 5px;
    padding: 1rem;
    flex-direction: column;
}
.input {
    width: 100%;
    padding: 10px;
    border-radius: 10px;
    outline: none;
    border: 0.5px solid #ddd;
    box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}
</style>