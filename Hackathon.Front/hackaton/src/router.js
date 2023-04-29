import { createRouter, createWebHistory } from 'vue-router'
import CadastroUsuario from './components/views/CadastroUsuario.vue'
import CadastroPet from './components/views/CadastroPet.vue'
import CadastroOng from './components/views/CadastroOng.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: CadastroUsuario
  },
  {
    path: '/about',
    name: 'About',
    component: CadastroPet
  },
  {
    path: '/contact',
    name: 'Contact',
    component: CadastroOng
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router