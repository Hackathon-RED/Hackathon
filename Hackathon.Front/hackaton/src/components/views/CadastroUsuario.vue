<template>
    <div class="card-cadastro">
      <i class="fa fa-user icones"/>
      <div class="title-cadastro">
          CADASTRO DE USUÁRIO
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
          <input/>
          
          <div>
            CPF:
          </div>
          <input/>

          <div>
            Email:
          </div>
          <input/>

          <div>
            Numero CRMV(Conselho Regional de Medicina Veterinária):
          </div>
          <input/>

          <div>
            UF:
          </div>
          <input/>

          <div>
            Especialidade:
          </div>
          <input/>
          
          <div>
            Endereço:
          </div>
          <input/>

          <div>
            Cidade:
          </div>
          <input/>

          <div>
            Cidade:
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
    align-items: center;

}

.teste ,.title-cadastro{
    font-size: 15px ;
    text-decoration: none;
  font-weight: bold;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}
</style>

