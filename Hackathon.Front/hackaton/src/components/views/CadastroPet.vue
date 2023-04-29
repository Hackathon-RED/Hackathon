<template>
    <div class="card-cadastro">
        <div>
            Imagem: 
            <input type="file"/>
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
            Ja é Castrado?
            <input type="checkbox"/>
          </div>
          
          
        </div>
        <div class="">    
            <button>CANCELAR</button>
            <button>SALVAR</button>
        </div>
    </div>
</template>

<script>

</script>







<style scoped>
.radio-btn {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    }
.card-cadastro{
  background: #028A0f;
    display: flex;
    border-radius:  5px;
    padding: 1rem;
    flex-direction: column;
}

.teste{
    font-family: 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, sans-serif;
    font-size: 20px ;
}

</style>

