import { ROUTER_DIRECTIVES }  from '@angular/router';
import { Component } from '@angular/core';
import { EpisodeListComponent } from './episodelist.component';
import { EpisodeService }     from './episode.service';
import { TfHeaderComponent } from './tfHeader.component';


@Component({
    selector: 'my-app',
    template: `
      <tfHeader [title]='title' [subTitle]='subTitle' class="col-xs-12 col-sm-12 col-md-12 col-lg-12"></tfHeader>
      <router-outlet></router-outlet>
    `,
  directives: [ROUTER_DIRECTIVES, TfHeaderComponent],
    providers: [
    EpisodeService
  ]

})
export class AppComponent { 
  'title' = 'Technology and Friends';
  'subTitle' = 'Talking with smart people about technology';
}
