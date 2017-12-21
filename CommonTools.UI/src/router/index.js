import Vue from 'vue'
import Router from 'vue-router'
import Index from '@/pages/Index'
import Encryption from '@/pages/Encryption'
import Language from '@/pages/Language'
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
      path:'/language',
      name:'Language',
      component:Language
    },{
      path:'/about',
      name:'About',
      component:About
    }
  ]
})
