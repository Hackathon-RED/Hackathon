<template>
    <div style="overflow-y: hidden;">
        <div style="display: flex; flex-wrap: wrap; justify-content: space-between; padding: 15px;">
        <div class="card" style="background-color: #028A0F;">
            <h3>R$ 14.900,00</h3>
        </div>
        <div class="card" style="background-color: #028A0F;">
            <h3>R$ 14.900,00</h3>
        </div>
        <div class="card" style="background-color: #028A0F;">
            <h3>R$ 14.900,00</h3>
        </div>

        <div class="card" style="width: 40%;">
            
        </div>
        <div class="card" style="width: 50%; height: 350px;">
            <div style="display: flex; flex-direction: column; width: 100%; height: 100%;">
                <div style="height: 15%;">
                    <h3 style="color: #131313;">Últimas Solicitações</h3>
                </div>
                <div class="lista-solicitacoes">
                    <ul>
                       <li>
                        <div style="display: flex;">
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
                       </li>
                       <li>
                        <div style="display: flex;">
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
                       </li>
                       <li>
                        <div style="display: flex;">
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
                       </li>
                       <li>
                        <div style="display: flex;">
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
                       </li>
                    </ul>
                </div>
            </div>
        </div>
        </div>
    </div>
</template>

<style scoped>
.card h5, .card p {
    margin: 0;
}
.card {
    padding: 5px 15px;
    background-color: white;
    box-shadow: 1px 1px 10px 1px rgba(0,0,0,0.35);
    border-radius: 15px;
    width: 25%;
    display: flex;
    align-items: center;
    justify-content: center;
    height: 150px;
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

</style>