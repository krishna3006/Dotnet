Type.registerNamespace("Sys.Extended.UI.Seadragon");Sys.Extended.UI.Seadragon.Rect=function(e,f,d,c){var a="number",b=this;b.x=typeof e==a?e:0;b.y=typeof f==a?f:0;b.width=typeof d==a?d:0;b.height=typeof c==a?c:0};Sys.Extended.UI.Seadragon.Rect.prototype={getAspectRatio:function(){return this.width/this.height},getTopLeft:function(){return new Sys.Extended.UI.Seadragon.Point(this.x,this.y)},getBottomRight:function(){var a=this;return new Sys.Extended.UI.Seadragon.Point(a.x+a.width,a.y+a.height)},getCenter:function(){var a=this;return new Sys.Extended.UI.Seadragon.Point(a.x+a.width/2,a.y+a.height/2)},getSize:function(){return new Sys.Extended.UI.Seadragon.Point(this.width,this.height)},equals:function(a){var b=this;return a instanceof Seadragon.Rect&&b.x===a.x&&b.y===a.y&&b.width===a.width&&b.height===a.height},toString:function(){var a=this;return "["+a.x+","+a.y+","+a.width+"x"+a.height+"]"}};Sys.Extended.UI.Seadragon.Rect.registerClass("Sys.Extended.UI.Seadragon.Rect",null,Sys.IDisposable);