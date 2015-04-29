<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Klient */

$this->title = 'Stwórz klienta';
$this->params['breadcrumbs'][] = ['label' => 'Klienci', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="klient-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
