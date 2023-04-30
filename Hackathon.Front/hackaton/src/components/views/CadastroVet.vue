<template>
    <div class="card-cadastro">
      <div class="title-cadastro">
        <i class="fa fa-user-md icones"/>
          CADASTRO DE VETERINÁRIO
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
            RG:
          </div>
          <input maxlength="9"/>
          <div>
            Orgão Emissor:
          </div>
          <input/>
          <div>
            Cpf:
          </div>
          <input/>
          <div>
            Endereço:
          </div>
          <input/>
          <div>
            Complemento:
          </div>
          <input/>
          <div>
            <div>
            Numero:
          </div>
          <input type="number"/>
          </div>
            <div>
            Cidade:
          </div>
          <input/>
            <div>
            CEP:
          </div>
          <input/>
          
        </div>
        <div class="btn">    
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
.icones{
  font-size: 50px;
}

.btn{
  margin-top: 1rem;
  display: flex;
  gap: 1rem;
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
    font-size: 15px ;
    text-decoration: none;
  font-weight: bold;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

</style>

