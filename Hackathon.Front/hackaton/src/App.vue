<script setup>
import CadastroPet from './components/views/CadastroPet.vue'
import CadastroUsuario from './components/views/CadastroUsuario.vue'
import CadastroOng from './components/views/CadastroOng.vue'
import ListaAdocao from './components/views/ListaAdocao.vue'
import { RouterView } from 'vue-router'

</script>

<template>
  <div id="nav">
    <ListaAdocao></ListaAdocao>
    <CadastroOng></CadastroOng>
    <CadastroUsuario></CadastroUsuario>
    <CadastroPet></CadastroPet>
    <router-link to="/">CadastroPet</router-link> |
    <router-link to="/profile">Profile</router-link>
    <router-view></router-view>  
    </div>
</template>

<style scoped>

header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  /* header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  } */
}
</style>
