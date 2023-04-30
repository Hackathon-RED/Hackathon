import { createRouter, createWebHistory } from 'vue-router'
import CadastroUsuario from './components/views/CadastroUsuario.vue'
import CadastroPet from './components/views/CadastroPet.vue'
import CadastroOng from './components/views/CadastroOng.vue'
import CadastroVer from './components/views/CadastroVet.vue'
import Dashboard from './components/views/Dashboard.vue'
import 'font-awesome/css/font-awesome.css'

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
  {
    path: '/cadastro-vet',
    name: 'cadastro-vet',
    component: CadastroVer
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router