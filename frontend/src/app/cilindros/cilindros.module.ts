import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutPageComponent } from './pages/layout-page/layout-page.component';
import { TablesCilindrosComponent } from './pages/tables-cilindros/tables-cilindros.component';
import { CreateCilindroComponent } from './pages/create-cilindro/create-cilindro.component';
import { EditCilindroComponent } from './pages/edit-cilindro/edit-cilindro.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CilindrosRoutingModule } from './cilindros-routing.module';
import { AngularMaterialModule } from '../angular-material/angular-material.module';



@NgModule({
  declarations: [
    LayoutPageComponent,
    TablesCilindrosComponent,
    CreateCilindroComponent,
    EditCilindroComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    CilindrosRoutingModule,
    AngularMaterialModule

  ]
})
export class CilindrosModule { }
