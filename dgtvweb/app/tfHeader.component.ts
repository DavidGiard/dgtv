import { Component, Input } from '@angular/core';
import { Router, ROUTER_DIRECTIVES } from '@angular/router';
import { appRouterProviders } from './app.routes';

@Component({
  selector: 'tfHeader',
  templateUrl: '/app/tf-header.html',
directives: [ROUTER_DIRECTIVES],
})
export class TfHeaderComponent {

  @Input()
  'title': string; 
  @Input()
  'subTitle': string;


}

