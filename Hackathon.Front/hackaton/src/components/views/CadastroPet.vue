<template>
    <div class="card-cadastro">
      <i class="fa fa-paw icones"/>
       <div class="title-cadastro">
         CADASTRO DE PETS
       </div>
        <div class="teste">
            Imagem: 
            <div>
              <input type="file"/>
            </div>
        </div>
        <div class="teste">
          <div>
            Nome do Animal:
          </div>
          <input/>
          <div>
            RGA (Opcional)
          </div>
          <input type="number"/>
          <div>
            Proprietário:
          </div>
          <input/>
          <div>
            Espécie:
          </div>
          <input/>
          <div>
            Raça:
          </div>
          <input/>
          <div>
            Porte:
          </div>
          <select id="cars">
              <option value="">Selecione um porte</option>
            <option value="pequeno">Pequeno</option>
            <option value="medio">Médio</option>
            <option value="grande">Grande</option>
        </select>

          <div>
            Data de Nascimento:
          </div>
          <input type="date"/>

          <div>
            Sexo do Animal
          </div>
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
            <input type="checkbox"/>
          </div>
          <div>
            É Vacinado?
            <input type="checkbox"/>
          </div>
          
          
        </div>
        <div class="btn">    
            <button>CANCELAR</button>
            <button>SALVAR</button>
        </div>
    </div>
</template>

<script>

</script>

<style scoped>

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
    font-size: 15px ;
    text-decoration: none;
  font-weight: bold;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

</style>

