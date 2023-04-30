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
                <input placeholder="Razão Social" class="input" value="Jéssica e Isabel Informática Ltda"/>
            </div>
            <div class="input-labels">
                <input placeholder="CNPJ" class="input"  value="49.639.688/0001-43"/>
            </div>
            <div class="input-labels">
                <input placeholder="Telefone" class="input" />
            </div>
            <div class="input-labels">
                
                <input placeholder="E-mail" class="input" value="pesquisa@jessicaeisabelinformaticaltda.com.br"/>
            </div>
            <div class="input-labels">
                <input placeholder="Responsável" class="input" />
            </div>
            <div class="input-labels">
                <input placeholder="CPF" class="input"/>
            </div>
        </div>
            <div style="width: 100%;row-gap: 1rem; display:flex; flex-wrap: wrap;">
                <div class="input-labels">
                    <input placeholder="Endereço" class="input" />
                </div>
                <div class="input-labels">
                    <input placeholder="Numero" class="input" />
                </div>
                <div class="input-labels">
                    <input placeholder="Complemento" class="input"/>
                </div>
                <div class="input-labels">
                    <input placeholder="Bairro" class="input" />
                </div>
                <div class="input-labels-cidade">
                    <div class="input-labels">
                        <input placeholder="Cidade" class="input"/>
                    </div>
                    <div class="input-labels">
                        <input placeholder="Estado" class="input" />
                    </div>
                </div>
                <div class="input-labels">
                    <input placeholder="Cep" class="input" value="11436-160" />
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