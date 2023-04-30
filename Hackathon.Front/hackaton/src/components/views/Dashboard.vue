<template>
    <div style="overflow-y: hidden;">
        <div style="display: flex; flex-wrap: wrap; justify-content: space-between; padding: 15px 30px;">
        <div class="card" style="justify-content: start;">
            <div style="max-width: 100px;"> 
                <img style="width: 100%;" src="./../../assets/img/dog.svg">
            </div>
            <div class="card-title">
                <p>Animais no abrigo</p>
                <h3 class="title">294</h3>
            </div>
        </div>
        <div class="card" style="justify-content: start;">
            <div style="max-width: 100px;"> 
                <img style="width: 100%;" src="./../../assets/img/friends.svg">
            </div>
            <div class="card-title">
                <p>Animais adotados do mês</p>
                <h3 class="title">37</h3>
            </div>
        </div>
        <div class="card" style="justify-content: start;">
            <div style="max-width: 100px;"> 
                <img style="width: 100%;" src="./../../assets/img/money.svg">
            </div>
            <div class="card-title">
                <p>Animais adotados do mês</p>
                <h3 class="title">R$ 3.500,00</h3>
            </div>
        </div>
        <div class="card" style="justify-content: start; background-color: #005438;">
            <div style="max-width: 100px;"> 
                <img style="width: 100%; filter:brightness(10)" src="./../../assets/img/cat.svg">
            </div>
            <div class="card-title">
                <p style="color: white;">Solicitações</p>
                <h3 class="title" style="color: white !important">294</h3>
            </div>
        </div>

        <div class="card" style="width: 40%;">
            
        </div>
        <div class="card" style="width: 50%; height: 350px;">
            <div style="display: flex; flex-direction: column; width: 100%; height: 100%;">
                <div style="height: 15%;">
                    <h3 style="color: #005438;">Últimas Solicitações</h3>
                </div>
                <div class="lista-solicitacoes">
                    <ul>
                       <li>
                        <div style="display: flex; justify-content: space-between;">
                            <div style="display: flex;">
                                <div style="max-width: 100px;">
                                    <img style="width: 100%; border-radius: 15px;" src="https://conteudo.imguol.com.br/c/entretenimento/54/2020/04/28/cachorro-pug-1588098472110_v2_900x506.jpg" />
                                </div>
                                <div style="margin-left: 15px;">
                                    <h5>Bob <i class="fa-solid fa-mars"></i></h5>
                                    <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                    <p style="font-size: 0.85em; opacity: .75; font-weight: bold;">Pug</p>
                                </div>
                            </div>
                            <div style="margin-right: 15px;">
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </li>
                       <li>
                        <div style="display: flex; justify-content: space-between;">
                            <div style="display: flex;">
                                <div style="max-width: 100px;">
                                    <img style="width: 100%; border-radius: 15px;" src="https://s2.glbimg.com/nvjFq8VRjyrpdQqaOeywz-5DFwY=/e.glbimg.com/og/ed/f/original/2021/08/27/captura_de_tela_2021-08-27_as_11.01.15.png" />
                                </div>
                                <div style="margin-left: 15px;">
                                    <h5>João <i class="fa-solid fa-mars"></i></h5>
                                    <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                    <p style="font-size: 0.85em; opacity: .75; font-weight: bold;">Dachshund</p>
                                </div>
                            </div>
                            <div style="margin-right: 15px;">
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </li>
                       <li>
                        <div style="display: flex; justify-content: space-between;">
                            <div style="display: flex;">
                                <div style="max-width: 100px;">
                                    <img style="width: 100%; border-radius: 15px;" src="https://www.petz.com.br/blog/wp-content/uploads/2022/02/gato-e-carnivoro2.jpg" />
                                </div>
                                <div style="margin-left: 15px;">
                                    <h5>Lulu <i class="fa-solid fa-venus"></i></h5>
                                    <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                    <p style="font-size: 0.85em; opacity: .75; font-weight: bold;">Siamês</p>
                                </div>
                            </div>
                            <div style="margin-right: 15px;">
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </li>
                       <li>
                        <div style="display: flex; justify-content: space-between;">
                            <div style="display: flex;">
                                <div style="max-width: 100px;">
                                    <img style="width: 100%; border-radius: 15px;" src="https://static1.patasdacasa.com.br/articles/9/18/99/@/8911-conheca-mais-sobre-o-corgi-essa-raca-su-articles_media_mobile-2.jpg" />
                                </div>
                                <div style="margin-left: 15px;">
                                    <h5>Maria <i class="fa-solid fa-venus"></i></h5>
                                    <p style="font-size: 0.85em;">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                    <p style="font-size: 0.85em; opacity: .75; font-weight: bold;">Corgi</p>
                                </div>
                            </div>
                            <div style="margin-right: 15px;">
                                <span>05/05/2023</span>
                            </div>
                        </div>
                       </li>
                    </ul>
                </div>
            </div>
        </div>
        </div>
    </div>
</template>

<style scoped>

.fa-venus {
    color: #E75480;
}

.fa-mars {
    color: #016064;
}

.card h5, .card p {
    margin: 0;
}
.card {
    padding: 5px 15px;
    background-color: white;
    box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
    border-radius: 15px;
    width: 20%;
    display: flex;
    align-items: center;
    justify-content: center;
    height: 100px;
    margin-bottom: 40px;
}

.card h3 {
    color: white;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

.lista-solicitacoes {
    height: 85%; 
    overflow-y: scroll;
}

.lista-solicitacoes ul {
    padding: 0;
}

.lista-solicitacoes ul li {
    list-style: none;
    margin-bottom: 15px;
}

.lista-solicitacoes ul li h5 {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

.lista-solicitacoes ul li p, .lista-solicitacoes ul li span {
    font-family: Arial, Helvetica, sans-serif;
}

.card-title { 
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 100%;
}

.title { 
    color: #005438 !important;
    width: 100%;
    text-align: center;
    font-size: 2em;
    margin: 0;
}

</style>