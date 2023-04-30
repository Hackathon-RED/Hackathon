import { createRouter, createWebHistory } from 'vue-router'
import CadastroUsuario from './components/views/CadastroUsuario.vue'
import CadastroPet from './components/views/CadastroPet.vue'
import CadastroOng from './components/views/CadastroOng.vue'
import Dashboard from './components/views/Dashboard.vue'

const routes = [
  {
    path: '/',
    name: 'Dashboard',
    component: Dashboard
  },
  {
    path: '/perfil',
    name: 'perfil',
    component: CadastroOng
  },
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router