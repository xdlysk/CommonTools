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
                <a href="#css" data-toggle="tab">
                    CSS
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
            <div class="tab-pane fade in" id="css">
                <langcss></langcss>
            </div>
        </div>
      
  </div>
</template>
<script>
import LangJs from '@/components/language/LangJs';
import LangHtml from '@/components/language/LangHtml';
import LangCss from '@/components/language/LangCss';
export default {
  name:'language',
  components:{
      langjs:LangJs,
      langhtml:LangHtml,
      langcss:LangCss
  }
}
</script>
