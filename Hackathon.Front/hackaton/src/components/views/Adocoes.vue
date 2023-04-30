<template>
    <div class="card-adocoes">
        <div class="title-cadastro">
            <img class="icon-doacao" src="./assets/adocao.svg"/>
            ADOÇÕES
        </div>

        <div class="lista-solicitacoes">
                    <ul class="aa">
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://conteudo.imguol.com.br/c/entretenimento/54/2020/04/28/cachorro-pug-1588098472110_v2_900x506.jpg" />
                            </div>
                            <div>
                                <h5>Bob <span>Macho</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7oMGvr7XstIJzLSJbKCMLHJjt8uE6Zj6nkw&usqp=CAU" />
                            </div>
                            <div>
                                <h5>Amora <span>Femêa</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://www.petz.com.br/blog/wp-content/uploads/2022/02/gato-e-carnivoro2.jpg" />
                            </div>
                            <div>
                                <h5>Lulu <span>Fêmea</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://static1.patasdacasa.com.br/articles/9/18/99/@/8911-conheca-mais-sobre-o-corgi-essa-raca-su-articles_media_mobile-2.jpg" />
                            </div>
                            <div>
                                <h5>Maria <span>Fêmea</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                        </div>
                        <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="data:image/jpeg;base64,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" />
                            </div>
                            <div>
                                <h5>Bola <span>Macho</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://s2.glbimg.com/nvjFq8VRjyrpdQqaOeywz-5DFwY=/e.glbimg.com/og/ed/f/original/2021/08/27/captura_de_tela_2021-08-27_as_11.01.15.png" />
                            </div>
                            <div>
                                <h5>Bob <span>Macho</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://www.petz.com.br/blog/wp-content/uploads/2022/02/gato-e-carnivoro2.jpg" />
                            </div>
                            <div>
                                <h5>Lulu <span>Fêmea</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPUT5onwPcQAcR1Ritcwk8dPs7nWyd2paZ2Q&usqp=CAU" />
                            </div>
                            <div>
                                <h5>Fifi <span>Fêmea</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://revistaanamaria.com.br/media/_versions/feedsync/entenda-a-importancia-dos-sapatos-para-cachorros-3235_widemd.jpg" />
                            </div>
                            <div>
                                <h5>Bill <span>Macho</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                       <div style="border-style: solid; border-radius: 25px; padding: 1rem; max-width: 20vw">
                        <div style="display: flex; gap: 10px">
                            <div style="max-width: 100px;">
                                <img style="width: 100%; border-radius: 15px;" src="https://static.wixstatic.com/media/e2e4ef_0b360155ffdd45858ac4204bdf67d053~mv2.jpeg/v1/fill/w_648,h_636,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/Maria%2520-%2520cachorro%2520para%2520adocao%2520-.jpeg" />
                            </div>
                            <div>
                                <h5>Caramelo <span>Macho</span></h5>
                                <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                            <div>
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </div>
                    </ul>
                </div>
    </div>
</template>

<style scoped>

.aa{
    display: flex;
    flex-wrap: wrap;
    gap: 2rem;
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

</style>