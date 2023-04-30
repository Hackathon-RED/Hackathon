<template>
    <div class="card">
        <div>
            <div class="title-perfil">
                <i class="fa-solid fa-user icones"></i>
                PERFIL
            </div>
        </div>
        <div>
            <div>
                <input placeholder="Razão Social" class="input" />
            </div>
        <div>
            <input placeholder="CNPJ" class="input" />
        </div>
        <div>

            <input placeholder="Endereço" class="input" />
        </div>
        <div>
            
            <input placeholder="Numero" class="input" />
        </div>
        <div>

            <input placeholder="Complemento" class="input"/>
        </div>
        <div>

            <input placeholder="Bairro" class="input" />
        </div>
        <div>

            <input placeholder="Cidade" class="input"/>
        </div>
        <div>

            <input placeholder="Estado" class="input" />
        </div>
        <div>
            
            <input placeholder="Cep" class="input" />
        </div>
        <div>

            <input placeholder="Telefone" class="input" />
        </div>
        <div>
            
            <input placeholder="E-mail" class="input"/>
        </div>
        <div>
            <input placeholder="Responsável" class="input" />
        </div>
        <div>
            <input placeholder="CPF" class="input"/>
        </div>
        </div>
    </div>
</template>

<style scoped>

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
    padding: 10px;
    border-radius: 10px;
    outline: none;
    border: 0.5px solid #ddd;
    box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}
</style>