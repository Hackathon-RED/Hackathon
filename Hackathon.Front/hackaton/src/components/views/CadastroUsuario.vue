<template>
    <div class="card-cadastro">
        <div>
            Imagem: 
            <input type="file"/>
        </div>
        <div class="teste">
          <div>
            Nome:
          </div>
          <input/>

          <div>
            Sobrenome:
          </div>
          <input/>

          <div>
            RG / CNH:
          </div>
          <input/>

          <div>
            Orgão Emissor:
          </div>

          <div>
            Cpf:
          </div>
          <input type="number"/>

          <div>
            <hr>
            <div>
              Endereço:
            </div>
            <input/>
            <div>
              <div>
              Numero:
            </div>
            <input type="number"/>
            </div>
            <div>
              <div>
              Complemento:
            </div>
            <input/>
            </div>
            <div>
              <div>
              CEP:
            </div>
            <input/>
            </div>
            
            <hr>
          </div>
          
        </div>
        <div class="">    
            <button>CANCELAR</button>
            <button>SALVAR</button>
        </div>
    </div>
</template>

<script>
// export default {
//     data: {
//         imagem: {
//             file: null, 
//             image: null 

//         } 
//     },
//     methods: {
//         onFileChange() {
//             const reader = new FileReader()
//             reader.readAsDataURL(this.file)
//             reader.onload = e => {
//                 this.image = e.target.result
//                 console.log(this.image)
//             }
//         },
//     },
// }

</script>



<style scoped>
.radio-btn {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    }
.card-cadastro{
  background: blue;
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

