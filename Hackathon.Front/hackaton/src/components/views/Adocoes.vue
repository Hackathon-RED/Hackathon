<template>
    <div class="card-adocoes">
        <div class="title-cadastro">
            <i style="color: #005438;" class="fa-solid fa-hand-holding-heart icones"/>
            <span style="color: #005438;">ANIMAIS</span>
        </div>

        <div class="lista-solicitacoes">
                    <ul class="aa">
                       <div class="card-pet" style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px; flex-direction: column;">
                            <div style="max-height: 150px;">
                                <img style="width: 100%; height: 150px; border-radius: 15px;" src="https://conteudo.imguol.com.br/c/entretenimento/54/2020/04/28/cachorro-pug-1588098472110_v2_900x506.jpg" />
                            </div>
                            <div>
                                <h5 style="display: flex; justify-content: space-between; width: 100%;">Bob<i class="fa-solid fa-mars"/></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div class="card-pet" style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px; flex-direction: column;">
                            <div style="max-height: 150px;">
                                <img style="width: 100%; height: 150px; border-radius: 15px;" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7oMGvr7XstIJzLSJbKCMLHJjt8uE6Zj6nkw&usqp=CAU" />
                            </div>
                            <div>
                                <h5 style="display: flex; justify-content: space-between; width: 100%;">Amora <i class="fa-solid fa-venus"/></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>21/04/2023</span>
                            </div>
                        </div>
                       </div>
                       <div class="card-pet" style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px; flex-direction: column;">
                            <div>
                                <img style="width: 100%; border-radius: 15px;" src="https://www.petz.com.br/blog/wp-content/uploads/2022/02/gato-e-carnivoro2.jpg" />
                            </div>
                            <div>
                                <h5 style="display: flex; justify-content: space-between; width: 100%;">Lulu <i class="fa-solid fa-venus"/></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>30/03/2023</span>
                            </div>
                        </div>
                       </div>
                    </ul>
                </div>
    </div>
    
</template>

<style scoped>

.card-pet{
  padding: 10px;
  border-radius: 10px;
  outline: none;
  border: 0.5px solid #ddd;
  box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
}

.fa-venus {
    color: #E75480;
}

.fa-mars {
    color: #016064;
}
.aa{
    display: flex;
    flex-wrap: wrap;
    gap: 2rem;
    padding: 0;
    margin: 0;
}


.lista-solicitacoes{
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    font-size: 20px;
}


.icon-doacao{
    width: 50px;
    height: 50px;
 }

 .card-adocoes{
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
.teste ,.title-cadastro{
    font-size: 25px ;
    text-decoration: none;
  font-weight: bold;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

h5 {
    margin: 0;
}

p {
    margin: 0;
}

</style>