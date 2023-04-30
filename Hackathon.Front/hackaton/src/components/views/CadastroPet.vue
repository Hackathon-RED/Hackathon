<template>
    <div class="card-cadastro">
      <div class="title-cadastro">
         <i class="fa fa-paw icones"/>
         CADASTRO DE PETS
       </div>
        <div class="teste">
            Foto do Pet
            <div>
              <input class="input-file" name="file" id="file" type="file"/>
              <label class="input-filee" for="file">Choose a file</label>
            </div>
          <div>
            <input placeholder="Nome do Pet" class="input"/>
          </div>
          <div>
            <input placeholder="RGA (Opcional)" class="input" type="number"/>
          </div>
          <div>
            <input placeholder="Proprietário" class="input"/>
          </div>
          <div>
            <input placeholder="Espécie" class="input"/>
          </div>
          <div>
            <input placeholder="Raça" class="input"/>
          </div>
          <div>
            <select class="input" id="cars">
              <option value="">Selecione um porte</option>
              <option value="pequeno">Pequeno</option>
              <option value="medio">Médio</option>
              <option value="grande">Grande</option>
            </select>
          </div>

          <div>
            Data de Nascimento:
          </div>
          <input class="input" type="date"/>
          Sexo do Animal
          <div class="radio-btn">
              <label for="huey">Masculino
                  <input type="radio" id="masc" name="SEXO" value="masc"/>
              </label>
              <label for="huey">Feminino
                  <input type="radio" id="fem" name="SEXO" value="fem"/>
              </label>
          </div>

          <div>
            É Castrado?
            <input class="input" type="checkbox"/>
          </div>
          <div>
            É Vacinado?
            <input class="input" type="checkbox"/>
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

.input-filee{
  cursor:pointer;
  padding: 10px;
  border-radius: 10px;
  outline: none;
  border: 0.5px solid #ddd;
  box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}
.input-file{
  width: 0.1px;
	height: 0.1px;
	opacity: 0;
	overflow: hidden;
	position: absolute;
	z-index: -1;
}

.input{
  padding: 10px;
  border-radius: 10px;
  outline: none;
  border: 0.5px solid #ddd;
  box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}
.input-check{
  padding: 15px;
  border-radius: 15px;
  outline: none;
  border: 0.5px solid #ddd;
  box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}
.btn-cancelar, .btn-salvar{
  padding: 10px;
  border-radius: 10px;
  outline: none;
  border: 0.5px solid #ddd;
  box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}

.icones{
  font-size: 50px;
}
.radio-btn {
    display: flex;
    align-items: flex-start;
    justify-content: space-between;
    gap: 3rem;
    }

.btn{
  margin-top: 1rem;
  display: flex;
  gap: 1rem;
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
    }

.title-cadastro{
    font-size: 25px ;
    text-decoration: none;
  font-weight: bold;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}
.teste {
  gap: 1rem;
    display: flex;
    font-size: 15px;
    text-decoration: none;
    font-weight: bold;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    flex-direction: column;
    align-items: flex-start;
}

</style>

