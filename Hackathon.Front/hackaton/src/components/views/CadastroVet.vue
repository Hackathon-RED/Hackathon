<template>
    <div class="card-cadastro">
      <div class="title-cadastro">
            <i style="color: #005438;" class="fa fa-user-md icon-dash icones"/>
            <span style="color: #005438;">CADASTRO DE VETERINÁRIO</span>
        </div>
        <div class="teste">
          <div style=" display: flex; width: 100%; gap: 1rem; flex-wrap: wrap;">
            <div class="labels">
              <input placeholder="Nome" class="input"/>
            </div>
            <div class="labels">
              <input placeholder="Sobrenome" class="input"/>
            </div>
            <div class="labels">
              <input placeholder="RG" class="input" maxlength="9"/>
            </div>
            <div class="labels">
              <input placeholder="Orgão Emissor" class="input"/>
            </div>
            <div class="labels">
              <input placeholder="Cpf" class="input"/>
            </div>
          </div>
          <div style=" display: flex; width: 100%; gap: 1rem; flex-wrap: wrap;">
            <div class="labels">
              <input placeholder="Endereço" class="input"/>
            </div>
            <div class="labels">
              <input placeholder="Complemento" class="input"/>
            </div>
              <div class="labels">
              <input placeholder="Numero" class="input"/>
            </div>
              <div class="labels">
              <input placeholder="Cidade" class="input"/>
            </div>
              <div class="labels">
              <input placeholder="CEP" class="input"/>
            </div>
          </div>
        </div>
        <div class="btn">    
            <button class="btn-cancelar">CANCELAR</button>
            <button class="btn-salvar">SALVAR</button>
        </div>
    </div>
</template>

<script>


</script>



<style scoped>
.labels{
  width: 100%;
  display:flex;
}

.input {
  width: 100%;
    padding: 10px;
    border-radius: 10px;
    outline: none;
    border: 0.5px solid #ddd;
    box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}

.icones{
  font-size: 50px;
}

.btn{
  margin-top: 1rem;
  display: flex;
  gap: 1rem;
}

.btn-cancelar, .btn-salvar{
  padding: 10px;
  border-radius: 10px;
  outline: none;
  border: 0.5px solid #ddd;
  box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}
.radio-btn {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    }
.card-cadastro{
  background: white;
    display: flex;
    border-radius: 5px;
    padding: 1rem;
    flex-direction: column;
}

.title-cadastro{
        padding-bottom: 1rem;
        display: flex;
        align-items: center;
        gap: 1rem;
        font-size: 25px ;
    text-decoration: none;
  font-weight: bold;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    }
.teste {
  display: flex;
    gap: 1rem;
    font-size: 15px;
    text-decoration: none;
    font-weight: bold;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

</style>

