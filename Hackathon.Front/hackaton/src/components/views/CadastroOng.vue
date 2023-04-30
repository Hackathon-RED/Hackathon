<template>
    <div class="card">
        <div>
            <input placeholder="Razão Social" class="input"/>
        </div>
        <div>
            <input placeholder="CNPJ" class="input"/>
        </div>
        <hr>
        <div>

            <input placeholder="Endereço" class="input"/>
        </div>
        <div>

            <input placeholder="Numero" class="input"/>
        </div>
        <div>

            <input placeholder="Complemento" class="input"/>
        </div>
        <div>

            <input placeholder="Bairro" class="input"/>
        </div>
        <div>

            <input placeholder="Cidade" class="input"/>
        </div>
        <div>

            <input placeholder="Estado" class="input"/>
        </div>
        <div>

            <input placeholder="Cep" class="input"/>
        </div>
        <div>

            <input placeholder="Telefone" class="input"/>
        </div>
        <div>

            <input placeholder="E-mail" class="input"/>
        </div>
        <hr>
        <div>
            <input placeholder="Responsável" class="input"/>
        </div>
        <div>
            <input placeholder="CPF" class="input"/>
        </div>
    </div>
</template>

<style scoped>
.card{
    display: flex;
    gap:1rem;
}
.input {
    padding: 10px;
    border-radius: 10px;
    outline: none;
    border: 0.5px solid #ddd;
    box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}
</style>