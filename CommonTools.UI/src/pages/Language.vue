<template>
    <div class="row">
      <ul class="nav nav-tabs">
            <li class="active">
                <a href="#js" data-toggle="tab">
                    JavaScript
                </a>
            </li>
            <li>
                <a href="#html" data-toggle="tab">
                    HTML
                </a>
            </li>
            <li>
                <a href="#other" data-toggle="tab">
                    其他
                </a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane fade in active" id="js">
                <langjs></langjs>
            </div>
            <div class="tab-pane fade in" id="html">
                <langhtml></langhtml>
            </div>
            <div class="tab-pane fade in" id="other">
            </div>
        </div>
      
  </div>
</template>
<script>
import LangJs from '@/components/language/LangJs';
import LangHtml from '@/components/language/LangHtml';
export default {
  name:'language',
  components:{
      langjs:LangJs,
      langhtml:LangHtml
  }
}
</script>
