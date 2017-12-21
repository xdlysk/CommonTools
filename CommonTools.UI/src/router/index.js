import Vue from 'vue'
import Router from 'vue-router'
import Index from '@/pages/Index'
import Encryption from '@/pages/Encryption'
import About from '@/pages/About'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Index',
      component: Index
    },{
      path:'/encryption',
      name:'Encryption',
      component:Encryption
    },{
      path:'/about',
      name:'About',
      component:About
    }
  ]
})
